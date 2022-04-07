CREATE TABLE maintenance_status (
   id             INTEGER        NOT NULL PRIMARY KEY,
   value          VARCHAR(10)    NOT NULL,
   description    VARCHAR(30)    NOT NULL
);

INSERT INTO maintenance_status (id, value, description)
VALUES (1, 'S', 'scheduled'),
       (2, 'R', 'requested'),
       (3, 'I', 'in progress'),
       (4, 'C', 'complete');


CREATE TABLE maintenance (
   id                         INTEGER                                      NOT NULL PRIMARY KEY,
   asset_id                   INTEGER REFERENCES asset (id)                NOT NULL,
   maintenance_status_id      INTEGER REFERENCES maintenance_status (id)   NOT NULL,
   date_out                   DATE,
   date_in                    DATE,
   description                VARCHAR(255)                                 NOT NULL
);
