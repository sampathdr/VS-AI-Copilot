# read a file and handle missing file errors

def read_file(file_path):
		try:
				with open(file_path, 'r') as file:
						content = file.read()
						print(content)
		except FileNotFoundError:
				print(f"Error: The file '{file_path}' was not found.")
		except Exception as e:
				print(f"An unexpected error occurred: {e}")