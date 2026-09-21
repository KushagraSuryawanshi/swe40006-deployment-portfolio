input_file = "/data/input.txt"
output_file = "/data/output.txt"

with open(input_file, "r") as file:
    text = file.read()

lines = len(text.splitlines())
words = len(text.split())
characters = len(text)

result = f"""Fil Processing Results
Lines: {lines}
Words: {words}
Characters: {characters}
"""

print(result)

with open(output_file, "w") as file:
    file.write(result)

print("Results saved to /data/output.txt")