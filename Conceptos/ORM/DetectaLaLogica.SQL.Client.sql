-- Create a client:
INSERT INTO clients (Name, Email)
VALUES ('client name', 'client email');

-- Read all clients:
SELECT * FROM clients;

-- Edit a client
UPDATE clients
SET Name = 'new client name', Email = 'new client email'
WHERE Id = client id;

-- Delete a client
DELETE FROM clients
WHERE Id = client id;