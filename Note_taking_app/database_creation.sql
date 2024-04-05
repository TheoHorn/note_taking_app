INSERT INTO NOTE (title, created_at, updated_at) VALUES ('Note 1', '2021-01-01 00:00:00', '2021-01-01 00:00:00');
INSERT INTO NOTE (title, created_at, updated_at) VALUES ('Note 2', '2021-01-02 00:00:00', '2021-01-02 00:00:00');
INSERT INTO NOTE (title, created_at, updated_at) VALUES ('Note 3', '2021-01-03 00:00:00', '2021-01-03 00:00:00');

INSERT INTO FILE (title, content, created_at, updated_at, idNote) VALUES ('File 1', 'Content 1', '2021-01-01 00:00:00', '2021-01-01 00:00:00', 1);
INSERT INTO FILE (title, content, created_at, updated_at, idNote) VALUES ('File 2', 'Content 2', '2021-01-02 00:00:00', '2021-01-02 00:00:00', 2);
INSERT INTO FILE (title, content, created_at, updated_at, idNote) VALUES ('File 3', 'Content 3', '2021-01-03 00:00:00', '2021-01-03 00:00:00', 2);

INSERT INTO TASK (title, created_at, updated_at, isCompleted, idNote,due) VALUES ('Task 1', '2021-01-01 00:00:00', '2021-01-01 00:00:00', 0, 1, '2021-01-03 00:00:00');
INSERT INTO TASK (title, created_at, updated_at, isCompleted, idNote,due) VALUES ('Task 2', '2021-01-02 00:00:00', '2021-01-02 00:00:00', 1, 3, '2021-01-07 00:00:00');
INSERT INTO TASK (title, created_at, updated_at, isCompleted, idNote,due) VALUES ('Task 3', '2021-01-03 00:00:00', '2021-01-03 00:00:00', 0, 3, '2021-01-05 00:00:00');