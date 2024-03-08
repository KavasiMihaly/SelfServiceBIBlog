import json
import chardet
import csv

#Add a parameter for the input and output file paths and names
input_file_path = r'inputfilepathandname'
output_file_path = r'outputfilepathandname'

# def detect_file_encoding(file_path):
#     with open(file_path, 'rb') as f:
#         result = chardet.detect(f.read())
#     return result['encoding']

# file_path = input_file_path
# encoding = detect_file_encoding(file_path)

# print(f'The encoding of the file is: {encoding}')

# Create a table to store the extracted information
table = []



# Load the JSON file
with open(input_file_path, 'r', encoding='utf-16') as file:
    try:
        # Parse the file data as JSON
        data = json.load(file)
        
        # Iterate over each section container
        for section in data['sections']:

            # Extract the id from the section
            section_id = section.get('id', '')
            section_pageid = section.get('name', '')
            section_pagename = section.get('displayName', '')
            
            # Iterate over each visual container in the section
            for visual_container in section.get('visualContainers', []):
                # Extract the id from the visual container
                visual_container_id = visual_container.get('id', '')
                # Extract the config attribute from the visual container
                config = visual_container.get('config', '')

                # Parse the config attribute as JSON
                try:
                    config_data = json.loads(config)
                    
                    # Get the displayname from the config data
                    visual_id = config_data.get('name', '')
                    visual_type = config_data.get('singleVisual', {}).get('visualType', '')
                    visual_name = config_data.get('singleVisual', {}).get('vcObjects', {}).get('title', [{}])[0].get('properties', {}).get('text', {}).get('expr', {}).get('Literal', {}).get('Value', '')
                    #get rid of the ' in the visual name
                    visual_name = visual_name.replace("'", "")

                    
                except json.JSONDecodeError:
                    # Handle JSON decoding errors
                    print("Error parsing config data")
                
                # Add the extracted information to the table
                table.append({
                    'section_id': section_id,
                    'pageid': section_pageid,
                    'pagename': section_pagename,
                    'visual_container_id': visual_container_id,
                    'visual_id': visual_id,
                    'visual_type': visual_type,
                    'visual_name': visual_name
                    
                })
    except json.JSONDecodeError:
        # Handle JSON decoding errors
        print("Error parsing JSON data")

# Print the table
for row in table:
    print(row)
    
# Save the table to a CSV file
with open(output_file_path, 'w', newline='', encoding='utf-8') as file:
    writer = csv.DictWriter(file, fieldnames=table[0].keys())
    writer.writeheader()
    writer.writerows(table)
