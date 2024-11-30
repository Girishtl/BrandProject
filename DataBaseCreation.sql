-- Create the database
CREATE DATABASE EasyTaskManagement_DataBase;



-- Create schema
CREATE SCHEMA appUser;

-- Create table within schema
CREATE TABLE appUser.users (
    id SERIAL PRIMARY KEY,                   -- Auto-incrementing primary key
    name VARCHAR(255) NOT NULL,              -- Name of the user
    phone_number VARCHAR(20),                -- Phone number (optional or can be constrained for length)
    email_address VARCHAR(255) UNIQUE NOT NULL,     -- Email address, with a limit on length
    password VARCHAR(255) NOT NULL,          -- Password, stored as a hash
    status VARCHAR(50) NOT NULL,             -- Status (e.g., active, inactive)
    modified_date TIMESTAMP DEFAULT NOW(),   -- Last modified timestamp, defaulting to current time
    create_date TIMESTAMP DEFAULT NOW(),     -- Creation timestamp, defaulting to current time
    modified_by VARCHAR(255),                -- Who modified the record
    created_by VARCHAR(255)                  -- Who created the record
);
