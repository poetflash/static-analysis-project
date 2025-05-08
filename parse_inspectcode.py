# parse_inspectcode.py
import xml.etree.ElementTree as ET

tree = ET.parse('inspectCodeResults.xml')
root = tree.getroot()

with open('report.txt', 'w') as report:
    for issue in root.iter('Issue'):
        file = issue.attrib.get('File', '')
        line = issue.attrib.get('Line', '1')
        message = issue.attrib.get('Message', '')
        report.write(f'{file}:{line}:1: warning: {message}\n')
