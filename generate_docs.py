import re, pathlib

root_dir = pathlib.Path('generated-code/Custom')
output_dir = pathlib.Path('docs/Custom')
output_dir.mkdir(parents=True, exist_ok=True)

for path in sorted(root_dir.glob('*.cs')):
    text = path.read_text()
    enum_match = re.search(r'public enum\s+(\w+)\s*:\s*\w+\s*{([^}]*)}', text, re.S)
    class_match = re.search(r'public partial class\s+(\w+)\s*:\s*([\w\.]+)', text)
    lines = []
    if enum_match:
        name = enum_match.group(1)
        body = enum_match.group(2)
        members = re.findall(r'(\w+)\s*=\s*(\d+)', body)
        lines.append(f"# {name}\n")
        lines.append("Enumeration values:\n")
        for k,v in members:
            lines.append(f"- **{k}** = {v}")
    elif class_match:
        name = class_match.group(1)
        base = class_match.group(2)
        props = re.findall(r'public ([\w<>\.]+) (\w+) { get; set; }', text)
        lines.append(f"# {name}\n")
        lines.append(f"Base class: `{base}`\n")
        if props:
            lines.append("Properties:")
            for typ,pname in props:
                lines.append(f"- `{pname}` ({typ})")
    else:
        continue
    out_path = output_dir / (path.stem + '.md')
    out_path.write_text('\n'.join(lines) + '\n')
print('Docs generated in', output_dir)
