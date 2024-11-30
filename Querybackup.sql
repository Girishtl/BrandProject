-- Create the database
CREATE DATABASE EasyTaskManagement_DataBase;



-- Create schema
CREATE SCHEMA appUser;


CREATE TABLE appuser.userRole (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    status VARCHAR(20) DEFAULT 'active'
);

INSERT INTO appuser.userRole (id, name, status) 
VALUES (1, 'Admin', 'active');


CREATE TABLE appuser.userService (
    id SERIAL PRIMARY KEY,
    ServiceName VARCHAR(100) NOT NULL,
    ServiceCost DECIMAL(10, 2) NOT NULL,
    ServiceDescription TEXT
);

ALTER TABLE appuser.userService
ADD COLUMN IsActive BOOLEAN NOT NULL DEFAULT TRUE;

CREATE TABLE appUser.UserWorkDetails (
    id SERIAL PRIMARY KEY,
    WorkName VARCHAR(100) NOT NULL,
    WorkCost DECIMAL(10, 2) NOT NULL,
    WorkDescription TEXT,
    ServiceID INT,
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ModifiedDate TIMESTAMP,
    CreatedBy VARCHAR(50),
    ModifiedBy VARCHAR(50),
    DeletedBy VARCHAR(50),
    DeletedDate TIMESTAMP,
    CONSTRAINT fk_service
        FOREIGN KEY (ServiceID)
        REFERENCES appuser.userService(id)
        ON DELETE SET NULL
);

ALTER TABLE appuser.userService
ADD COLUMN CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
ADD COLUMN ModifiedDate TIMESTAMP,
ADD COLUMN CreatedBy VARCHAR(50),
ADD COLUMN ModifiedBy VARCHAR(50),
ADD COLUMN DeletedBy VARCHAR(50),
ADD COLUMN DeletedDate TIMESTAMP;

CREATE TABLE appUser.users (
    id SERIAL PRIMARY KEY,                         -- Auto-incrementing primary key
    name VARCHAR(255) NOT NULL,                    -- Name of the user
    phone_number VARCHAR(20),                      -- Phone number (optional)
    email_address VARCHAR(255) UNIQUE NOT NULL,    -- Email address, with a unique constraint
    password VARCHAR(255) NOT NULL,                -- Password, stored as a hash
    status VARCHAR(50) NOT NULL,                   -- Status (e.g., active, inactive)
    modified_date TIMESTAMP,                       -- Last modified timestamp
    create_date TIMESTAMP DEFAULT NOW(),           -- Creation timestamp, defaults to current time
    modified_by VARCHAR(255),                      -- Identifier of who modified the record
    created_by VARCHAR(255),                       -- Identifier of who created the record
    role_id INT,                                   -- Foreign key to userRole table
    service_id INT,                                -- Foreign key to userService table
    deleted_by VARCHAR(255),                       -- Identifier of who deleted the record
    deleted_date TIMESTAMP,                        -- Deletion timestamp

    CONSTRAINT fk_role                             -- Foreign key constraint for role_id
        FOREIGN KEY (role_id)
        REFERENCES appuser.userRole(id)
        ON DELETE SET NULL,
    
    CONSTRAINT fk_service                          -- Foreign key constraint for service_id
        FOREIGN KEY (service_id)
        REFERENCES appuser.userService(id)
        ON DELETE SET NULL
);



ALTER TABLE appUser.users
ALTER COLUMN password SET DEFAULT 'admin123';




CREATE TABLE LeadStatus (
    LeadID INT PRIMARY KEY,         -- Unique identifier for each lead (not auto-incremented)
    LeadName VARCHAR(255) NOT NULL, -- Name of the lead
    IsActive BOOLEAN NOT NULL       -- Active status of the lead (TRUE for active, FALSE for inactive)
);