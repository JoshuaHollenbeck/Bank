/* Run Second */
TRUNCATE TABLE cust_emp;
TRUNCATE TABLE cust_contact;
TRUNCATE TABLE cust_id;
TRUNCATE TABLE cust_privacy;
TRUNCATE TABLE cust_tax;
TRUNCATE TABLE acct_pass;
TRUNCATE TABLE acct_contact;
TRUNCATE TABLE acct_jurisdiction;
TRUNCATE TABLE acct_holders;
TRUNCATE TABLE acct_bene;
TRUNCATE TABLE acct_poa;
TRUNCATE TABLE acct_bal;
DELETE FROM acct_info;
DBCC CHECKIDENT ('acct_info', RESEED, 0);
DELETE FROM cust_info;
DBCC CHECKIDENT ('cust_info', RESEED, 0);