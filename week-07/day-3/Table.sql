CREATE TABLE tasks (
  ID INT,
  done BIT,
  taskDescription VARCHAR(255),
);

INSERT INTO tasks (ID, done, taskDescription) VALUES 1, 1, "Eat pizza"
INSERT INTO tasks (ID, done, taskDescription) VALUES 2, 0, "Practice programming"
INSERT INTO tasks (ID, done, taskDescription) VALUES 3, 0, "Visit dentist"

SELECT * 
FROM tasks 
WHERE ID = 1

SELECT taskDescription 
FROM tasks 
WHERE done = 1

UPDATE tasks
SET taskDescription = "Done"
WHERE done = 1

DELETE FROM tasks 
WHERE taskDescription = "Eat pizza"
