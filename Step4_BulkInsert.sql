--Run Third
/*
--PC
-- Bulk insert account information 
BULK INSERT acct_info
FROM 'G:\Github\DataGeneration\DataGeneration\acct_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2)

BULK INSERT acct_bal
FROM 'G:\Github\DataGeneration\DataGeneration\acct_bal.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_bene
FROM 'G:\Github\DataGeneration\DataGeneration\acct_bene.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);		

BULK INSERT acct_branch
FROM 'G:\Github\DataGeneration\DataGeneration\acct_branch.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_contact
FROM 'G:\Github\DataGeneration\DataGeneration\acct_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_holders
FROM 'G:\Github\DataGeneration\DataGeneration\acct_holders.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_jurisdiction
FROM 'G:\Github\DataGeneration\DataGeneration\acct_jurisdiction.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);		

BULK INSERT acct_limit
FROM 'G:\Github\DataGeneration\DataGeneration\acct_limit.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_mobile
FROM 'G:\Github\DataGeneration\DataGeneration\acct_mobile.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_pass
FROM 'G:\Github\DataGeneration\DataGeneration\acct_pass.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_poa
FROM 'G:\Github\DataGeneration\DataGeneration\acct_poa.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

-- Bulk insert customer information 
BULK INSERT cust_info
FROM 'G:\Github\DataGeneration\DataGeneration\cust_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_contact
FROM 'G:\Github\DataGeneration\DataGeneration\cust_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT cust_emp
FROM 'G:\Github\DataGeneration\DataGeneration\cust_emp.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_id
FROM 'G:\Github\DataGeneration\DataGeneration\cust_id.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_privacy
FROM 'G:\Github\DataGeneration\DataGeneration\cust_privacy.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_tax
FROM 'G:\Github\DataGeneration\DataGeneration\cust_tax.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

-- Bulk insert employee information 
BULK INSERT emp_info
FROM 'G:\Github\DataGeneration\DataGeneration\emp_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_contact
FROM 'G:\Github\DataGeneration\DataGeneration\emp_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_position
FROM 'G:\Github\DataGeneration\DataGeneration\emp_position.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT emp_salary
FROM 'G:\Github\DataGeneration\DataGeneration\emp_salary.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT emp_tax
FROM 'G:\Github\DataGeneration\DataGeneration\emp_tax.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_termination
FROM 'G:\Github\DataGeneration\DataGeneration\emp_termination.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
*/

-- Laptop 
-- Bulk insert account information 
BULK INSERT acct_info
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2)

BULK INSERT acct_bal
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_bal.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_bene
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_bene.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);		

BULK INSERT acct_branch
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_branch.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_contact
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_holders
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_holders.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_jurisdiction
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_jurisdiction.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);		

BULK INSERT acct_limit
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_limit.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_mobile
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_mobile.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT acct_pass
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_pass.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT acct_poa
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\acct_poa.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

-- Bulk insert customer information 
BULK INSERT cust_info
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_contact
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT cust_emp
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_emp.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_id
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_id.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_privacy
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_privacy.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

BULK INSERT cust_tax
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\cust_tax.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);	

-- Bulk insert employee information 
BULK INSERT emp_info
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_info.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_contact
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_contact.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_position
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_position.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT emp_salary
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_salary.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);
    
BULK INSERT emp_tax
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_tax.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);

BULK INSERT emp_termination
FROM 'C:\Users\Juice\Documents\Software\Github\DataGeneration\emp_termination.csv'
WITH (FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    ROWTERMINATOR='\n',
    BATCHSIZE=250000,
    MAXERRORS=2);