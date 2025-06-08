import os
import re
from pathlib import Path

def parse_cs_file(path):
    path = Path(path)
    text = path.read_text(encoding='utf-8', errors='ignore')
    namespace_match = re.search(r'namespace\s+([\w\.]+)', text)
    namespace = namespace_match.group(1) if namespace_match else 'Unknown'
    type_match = re.search(r'public\s+(?:partial\s+)?(class|interface|struct|enum)\s+(\w+)', text)
    if not type_match:
        return None
    kind, name = type_match.group(1), type_match.group(2)

    props = re.findall(r'public\s+([\w\.<>,\[\]]+)\s+(\w+)\s*{', text)
    methods = re.findall(r'public\s+([\w\.<>,\[\]]+)\s+(\w+)\s*\(([^\)]*)\)', text)

    return {
        'namespace': namespace,
        'kind': kind,
        'name': name,
        'properties': props,
        'methods': methods,
        'path': path
    }

def generate_doc(info):
    lines = []
    lines.append(f"# {info['name']}")
    lines.append("")
    lines.append(f"Namespace: `{info['namespace']}`")
    lines.append(f"Type: {info['kind']}")
    lines.append("")
    lines.append("This documentation is generated from reflection scaffolding and may be incomplete.")

    if info['properties']:
        lines.append("\n## Properties")
        for t, n in info['properties']:
            lines.append(f"- `{n}` ({t})")

    method_lines = []
    for ret, mname, params in info['methods']:
        # skip property-style declarations
        if any(n == mname for _, n in info['properties']):
            continue
        mparams = params.strip() if params.strip() else 'void'
        method_lines.append(f"- `{mname}({mparams})` : {ret}")
    if method_lines:
        lines.append("\n## Methods")
        lines.extend(method_lines)

    if info['kind'] == 'enum':
        values = re.findall(r'^\s*(\w+)\s*(?:=|,|$)', info['path'].read_text(), re.MULTILINE)
        if values:
            lines.append("\n## Enum Values")
            for v in values:
                lines.append(f"- `{v}`")

    lines.append("")
    return "\n".join(lines)


def main():
    src_dir = Path('generated-code/Core')
    dst_dir = Path('docs/Core')
    dst_dir.mkdir(parents=True, exist_ok=True)
    for cs_file in sorted(src_dir.glob('*.cs')):
        info = parse_cs_file(cs_file)
        if not info:
            continue
        doc_text = generate_doc(info)
        dst_path = dst_dir / (cs_file.stem + '.md')
        dst_path.write_text(doc_text)

if __name__ == '__main__':
    main()
