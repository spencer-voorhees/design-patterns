using Prototype;

// Create the base template
DocumentTemplate baseTemplate = new DocumentTemplate("Project Title", "Project Details");

baseTemplate.Display();

// Create a report based on the template
DocumentTemplate report = baseTemplate.Clone();
report.Title = "Q1 Report";
report.Body += " - These are the details for the Q1 report.";

report.Display();