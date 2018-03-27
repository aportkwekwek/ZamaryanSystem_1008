-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 06, 2018 at 03:01 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `accountingsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `billingitem`
--

CREATE TABLE IF NOT EXISTS `billingitem` (
  `APVid` varchar(9) DEFAULT NULL,
  `accountid` int(99) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `amount` float DEFAULT NULL,
  `vat` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `billings`
--

CREATE TABLE IF NOT EXISTS `billings` (
  `dateBill` date DEFAULT NULL,
  `totalBill` float DEFAULT NULL,
  `inputVat` float DEFAULT NULL,
  `APVid` varchar(9) NOT NULL,
  `isPaid` varchar(255) DEFAULT NULL,
  `supplierid` int(12) DEFAULT NULL,
  `duedate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashdisbursment`
--

CREATE TABLE IF NOT EXISTS `cashdisbursment` (
  `disbursmentID` varchar(8) NOT NULL,
  `date` date DEFAULT NULL,
  `grandTotal` float(99,2) DEFAULT NULL,
  `totalCWT` float(99,2) DEFAULT NULL,
  `method` int(99) DEFAULT NULL,
  `amountinwords` varchar(999) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashdisbursmentapv`
--

CREATE TABLE IF NOT EXISTS `cashdisbursmentapv` (
  `disbursmentid` varchar(8) DEFAULT NULL,
  `APVid` varchar(9) DEFAULT NULL,
  `CWT` float(99,2) DEFAULT NULL,
  `amountPaid` float(99,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashdisbursmentrr`
--

CREATE TABLE IF NOT EXISTS `cashdisbursmentrr` (
  `disbursmentid` varchar(8) DEFAULT NULL,
  `reportid` varchar(9) DEFAULT NULL,
  `CWT` float(99,2) DEFAULT NULL,
  `amountPaid` float(99,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashreceipts`
--

CREATE TABLE IF NOT EXISTS `cashreceipts` (
  `receiptID` varchar(8) NOT NULL,
  `date` date DEFAULT NULL,
  `grandTotal` float(99,2) DEFAULT NULL,
  `totalCWT` float(99,2) DEFAULT NULL,
  `method` int(99) DEFAULT NULL,
  `amountinwords` varchar(999) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cashreceipts`
--

INSERT INTO `cashreceipts` (`receiptID`, `date`, `grandTotal`, `totalCWT`, `method`, `amountinwords`) VALUES
('CR100001', '2018-02-08', 0.00, 0.00, NULL, '');

-- --------------------------------------------------------

--
-- Table structure for table `cashreceiptsinvoice`
--

CREATE TABLE IF NOT EXISTS `cashreceiptsinvoice` (
  `receiptid` varchar(8) DEFAULT NULL,
  `invoiceid` int(11) DEFAULT NULL,
  `CWT` float(99,2) DEFAULT NULL,
  `amountPaid` float(99,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `chartofaccounts`
--

CREATE TABLE IF NOT EXISTS `chartofaccounts` (
`accountid` int(4) NOT NULL,
  `accountname` varchar(64) NOT NULL,
  `accountcode` varchar(8) NOT NULL,
  `accountgroup` varchar(64) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chartofaccounts`
--

INSERT INTO `chartofaccounts` (`accountid`, `accountname`, `accountcode`, `accountgroup`) VALUES
(3, 'Cash', '1001', 'Current Assets'),
(4, 'Accounts Receivable', '1002', 'Current Assets'),
(5, 'Inventory', '1003', 'Current Assets'),
(6, 'Input VAT', '1004', 'Current Assets'),
(7, 'PPE', '1005', 'Noncurrent Assets'),
(8, 'Accounts Payable', '2001', 'Liabilities'),
(9, 'Output VAT', '2002', 'Liabilities'),
(10, 'Loans', '2003', 'Liabilities'),
(11, 'Capital Stock', '3001', 'Equity'),
(12, 'Retained Earnings', '3002', 'Equity'),
(13, 'Sales', '4001', 'Profit'),
(14, 'Cost of Sales', '5001', 'Profit'),
(15, 'Salaries and Wages', '6001', 'General & Administrative Expenses'),
(16, 'Utilities', '6002', 'General & Administrative Expenses'),
(17, 'Rent', '6003', 'General & Administrative Expenses'),
(18, 'Office Supplies', '6004', 'General & Administrative Expenses'),
(19, 'Cash in Bank - Petty Cash', '1001.1', 'Current Assets'),
(20, 'Cash in Bank - BDO', '1001.2', 'Current Assets'),
(21, 'Cash in Bank - Metrobank', '1001.3', 'Current Assets'),
(22, 'Cash in Bank - BPI', '1001.4', 'Current Assets'),
(23, 'Creditable Withholding Tax', '1007', 'Current Assets'),
(24, 'Withholding Tax Payable', '2004', 'Liabilities'),
(26, 'Labor', '1006', 'General & Administrative Expenses');

-- --------------------------------------------------------

--
-- Table structure for table `companies`
--

CREATE TABLE IF NOT EXISTS `companies` (
  `companyname` varchar(32) NOT NULL,
  `companyaddress` varchar(96) NOT NULL,
  `companyzip` varchar(8) NOT NULL,
  `companyphone` varchar(16) NOT NULL,
  `companyfax` varchar(16) NOT NULL,
  `companywebsite` varchar(32) NOT NULL,
  `companycontactperson` varchar(32) NOT NULL,
  `companyemail` varchar(32) NOT NULL,
  `tin` varchar(16) NOT NULL,
  `CWT` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `companies`
--

INSERT INTO `companies` (`companyname`, `companyaddress`, `companyzip`, `companyphone`, `companyfax`, `companywebsite`, `companycontactperson`, `companyemail`, `tin`, `CWT`) VALUES
('Zamaryan Holdings', 'Taguig City ', '1630', ' (02) 551 1216', '55-55-88-99', '-', 'HR', 'zamaryan@gmail.com', '555-444-333', 2);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
`customerid` int(12) NOT NULL,
  `customername` varchar(32) NOT NULL,
  `customeraddress` varchar(96) NOT NULL,
  `customerzip` varchar(8) NOT NULL,
  `customerphone` varchar(16) NOT NULL,
  `customerfax` varchar(16) NOT NULL,
  `customercontactperson` varchar(32) NOT NULL,
  `customeremail` varchar(32) NOT NULL,
  `customertin` varchar(16) NOT NULL,
  `termsofAgreement` int(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `invoiceitems`
--

CREATE TABLE IF NOT EXISTS `invoiceitems` (
  `invoiceid` int(11) DEFAULT NULL,
  `itemnumber` int(12) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `costGoodSold` float(99,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
`itemnumber` int(12) NOT NULL,
  `itemid` varchar(12) NOT NULL,
  `itemdesc` varchar(250) NOT NULL,
  `quantity` int(99) NOT NULL,
  `sellingPrice` float(99,2) NOT NULL,
  `runningBalance` float(99,2) NOT NULL,
  `isVatable` varchar(3) NOT NULL,
  `quota` int(99) NOT NULL,
  `maxQuota` int(11) NOT NULL,
  `unitofmeasurement` varchar(25) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `journal`
--

CREATE TABLE IF NOT EXISTS `journal` (
`journalid` int(8) NOT NULL,
  `journaldesc` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `journalentry`
--

CREATE TABLE IF NOT EXISTS `journalentry` (
`journalentryid` int(8) NOT NULL,
  `journalid` int(8) DEFAULT NULL,
  `journaldate` date DEFAULT NULL,
  `accountid` int(99) DEFAULT NULL,
  `journaldebit` float(99,2) DEFAULT NULL,
  `journalcredit` float(99,2) DEFAULT NULL,
  `source` varchar(999) NOT NULL,
  `source2` varchar(999) NOT NULL,
  `runningBal` float(99,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorder`
--

CREATE TABLE IF NOT EXISTS `purchaseorder` (
`purchaseorderid` int(99) NOT NULL,
  `purchaseorderdate` datetime DEFAULT NULL,
  `supplierid` int(12) DEFAULT NULL,
  `termsInDays` int(11) DEFAULT NULL,
  `inputVat` float(255,2) NOT NULL,
  `total` float(255,2) NOT NULL,
  `remarks` varchar(999) NOT NULL,
  `remarks2` varchar(999) NOT NULL,
  `poid` varchar(999) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `purchaseorder`
--

INSERT INTO `purchaseorder` (`purchaseorderid`, `purchaseorderdate`, `supplierid`, `termsInDays`, `inputVat`, `total`, `remarks`, `remarks2`, `poid`) VALUES
(1, NULL, NULL, NULL, 0.00, 0.00, 'NULL', '', 'PO1000001');

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorderitems`
--

CREATE TABLE IF NOT EXISTS `purchaseorderitems` (
  `purchaseorderid` int(99) DEFAULT NULL,
  `itemnumber` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `quantityArrived` int(11) NOT NULL,
  `cost` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `receivingitems`
--

CREATE TABLE IF NOT EXISTS `receivingitems` (
  `reportid` varchar(9) DEFAULT NULL,
  `itemnumber` int(12) DEFAULT NULL,
  `quantityreceived` int(11) DEFAULT NULL,
  `cost` float(99,2) DEFAULT NULL,
  `inputVat` float(99,2) DEFAULT NULL,
  `total` float(99,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `receivingreport`
--

CREATE TABLE IF NOT EXISTS `receivingreport` (
  `reportid` varchar(9) NOT NULL,
  `purchaseorderid` int(99) DEFAULT NULL,
  `datedelivered` date DEFAULT NULL,
  `inputVat` float(99,2) DEFAULT NULL,
  `total` float(99,2) DEFAULT NULL,
  `duedate` date NOT NULL,
  `status` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `receivingreport`
--

INSERT INTO `receivingreport` (`reportid`, `purchaseorderid`, `datedelivered`, `inputVat`, `total`, `duedate`, `status`) VALUES
('RR100001', NULL, NULL, 0.00, 0.00, '0000-00-00', 'NULL');

-- --------------------------------------------------------

--
-- Table structure for table `salesinvoice`
--

CREATE TABLE IF NOT EXISTS `salesinvoice` (
`invoiceid` int(11) NOT NULL,
  `customerid` int(12) DEFAULT NULL,
  `datesold` datetime DEFAULT NULL,
  `total` float(99,2) DEFAULT NULL,
  `outputVat` float DEFAULT NULL,
  `salesperson` int(99) DEFAULT NULL,
  `pono` varchar(999) NOT NULL,
  `remarks` varchar(999) NOT NULL,
  `cashCollected` float(99,2) NOT NULL,
  `sid` varchar(8) DEFAULT NULL,
  `costofsalesTot` float(99,2) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salesinvoice`
--

INSERT INTO `salesinvoice` (`invoiceid`, `customerid`, `datesold`, `total`, `outputVat`, `salesperson`, `pono`, `remarks`, `cashCollected`, `sid`, `costofsalesTot`) VALUES
(1, NULL, '2018-02-19 00:00:00', 0.00, 0, NULL, 'potest', 'Approved', 0.00, 'SI100001', 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE IF NOT EXISTS `suppliers` (
`supplierid` int(12) NOT NULL,
  `suppliername` varchar(32) NOT NULL,
  `supplieraddress` varchar(96) NOT NULL,
  `supplierzip` varchar(8) NOT NULL,
  `supplierphone` varchar(16) NOT NULL,
  `supplierfax` varchar(16) NOT NULL,
  `supplierwebsite` varchar(32) NOT NULL,
  `suppliercontactperson` varchar(32) NOT NULL,
  `supplieremail` varchar(32) NOT NULL,
  `suppliertin` varchar(16) NOT NULL,
  `termsofAgreement` int(99) NOT NULL,
  `vendorTax` int(11) NOT NULL,
  `InventorySupplier` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `uniqueitem`
--

CREATE TABLE IF NOT EXISTS `uniqueitem` (
`uniqueItem` int(99) NOT NULL,
  `itemnumber` int(12) DEFAULT NULL,
  `cost` float(99,2) DEFAULT NULL,
  `isInventory` varchar(3) DEFAULT NULL,
  `dateInventory` date DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
`id` int(99) NOT NULL,
  `username` varchar(999) NOT NULL,
  `password` varchar(999) NOT NULL,
  `name` varchar(999) NOT NULL,
  `usertype` varchar(999) NOT NULL,
  `employeenumber` varchar(999) NOT NULL,
  `accesslevel` varchar(999) NOT NULL DEFAULT '1'
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`, `usertype`, `employeenumber`, `accesslevel`) VALUES
(2, 'cenon', 'cenon', 'cenon', 'Employee', 'GTC-1232', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billingitem`
--
ALTER TABLE `billingitem`
 ADD KEY `APVid` (`APVid`), ADD KEY `accountid` (`accountid`);

--
-- Indexes for table `billings`
--
ALTER TABLE `billings`
 ADD PRIMARY KEY (`APVid`), ADD KEY `supplierid` (`supplierid`);

--
-- Indexes for table `cashdisbursment`
--
ALTER TABLE `cashdisbursment`
 ADD PRIMARY KEY (`disbursmentID`);

--
-- Indexes for table `cashdisbursmentapv`
--
ALTER TABLE `cashdisbursmentapv`
 ADD KEY `disbursmentid` (`disbursmentid`), ADD KEY `APVid` (`APVid`);

--
-- Indexes for table `cashdisbursmentrr`
--
ALTER TABLE `cashdisbursmentrr`
 ADD KEY `disbursmentid` (`disbursmentid`), ADD KEY `reportid` (`reportid`);

--
-- Indexes for table `cashreceipts`
--
ALTER TABLE `cashreceipts`
 ADD PRIMARY KEY (`receiptID`), ADD KEY `method` (`method`);

--
-- Indexes for table `cashreceiptsinvoice`
--
ALTER TABLE `cashreceiptsinvoice`
 ADD KEY `receiptid` (`receiptid`), ADD KEY `invoiceid` (`invoiceid`);

--
-- Indexes for table `chartofaccounts`
--
ALTER TABLE `chartofaccounts`
 ADD PRIMARY KEY (`accountid`), ADD UNIQUE KEY `accountname` (`accountname`), ADD UNIQUE KEY `accountcode` (`accountcode`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
 ADD PRIMARY KEY (`customerid`);

--
-- Indexes for table `invoiceitems`
--
ALTER TABLE `invoiceitems`
 ADD KEY `invoiceid` (`invoiceid`), ADD KEY `itemnumber` (`itemnumber`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
 ADD PRIMARY KEY (`itemnumber`);

--
-- Indexes for table `journal`
--
ALTER TABLE `journal`
 ADD PRIMARY KEY (`journalid`);

--
-- Indexes for table `journalentry`
--
ALTER TABLE `journalentry`
 ADD PRIMARY KEY (`journalentryid`), ADD KEY `journalid` (`journalid`), ADD KEY `accountid` (`accountid`);

--
-- Indexes for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
 ADD PRIMARY KEY (`purchaseorderid`), ADD KEY `supplierid` (`supplierid`);

--
-- Indexes for table `purchaseorderitems`
--
ALTER TABLE `purchaseorderitems`
 ADD KEY `purchaseorderid` (`purchaseorderid`), ADD KEY `itemnumber` (`itemnumber`);

--
-- Indexes for table `receivingitems`
--
ALTER TABLE `receivingitems`
 ADD KEY `reportid` (`reportid`), ADD KEY `itemnumber` (`itemnumber`);

--
-- Indexes for table `receivingreport`
--
ALTER TABLE `receivingreport`
 ADD PRIMARY KEY (`reportid`), ADD KEY `purchaseorderid` (`purchaseorderid`);

--
-- Indexes for table `salesinvoice`
--
ALTER TABLE `salesinvoice`
 ADD PRIMARY KEY (`invoiceid`), ADD KEY `customerid` (`customerid`), ADD KEY `salesperson` (`salesperson`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
 ADD PRIMARY KEY (`supplierid`);

--
-- Indexes for table `uniqueitem`
--
ALTER TABLE `uniqueitem`
 ADD PRIMARY KEY (`uniqueItem`), ADD KEY `itemnumber` (`itemnumber`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chartofaccounts`
--
ALTER TABLE `chartofaccounts`
MODIFY `accountid` int(4) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
MODIFY `customerid` int(12) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
MODIFY `itemnumber` int(12) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `journal`
--
ALTER TABLE `journal`
MODIFY `journalid` int(8) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `journalentry`
--
ALTER TABLE `journalentry`
MODIFY `journalentryid` int(8) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
MODIFY `purchaseorderid` int(99) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `salesinvoice`
--
ALTER TABLE `salesinvoice`
MODIFY `invoiceid` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
MODIFY `supplierid` int(12) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `uniqueitem`
--
ALTER TABLE `uniqueitem`
MODIFY `uniqueItem` int(99) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
MODIFY `id` int(99) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `billingitem`
--
ALTER TABLE `billingitem`
ADD CONSTRAINT `billingitem_ibfk_1` FOREIGN KEY (`APVid`) REFERENCES `billings` (`APVid`),
ADD CONSTRAINT `billingitem_ibfk_2` FOREIGN KEY (`accountid`) REFERENCES `chartofaccounts` (`accountid`);

--
-- Constraints for table `billings`
--
ALTER TABLE `billings`
ADD CONSTRAINT `billings_ibfk_1` FOREIGN KEY (`supplierid`) REFERENCES `suppliers` (`supplierid`);

--
-- Constraints for table `cashdisbursmentapv`
--
ALTER TABLE `cashdisbursmentapv`
ADD CONSTRAINT `cashdisbursmentapv_ibfk_1` FOREIGN KEY (`disbursmentid`) REFERENCES `cashdisbursment` (`disbursmentID`),
ADD CONSTRAINT `cashdisbursmentapv_ibfk_2` FOREIGN KEY (`APVid`) REFERENCES `billings` (`APVid`);

--
-- Constraints for table `cashdisbursmentrr`
--
ALTER TABLE `cashdisbursmentrr`
ADD CONSTRAINT `cashdisbursmentrr_ibfk_1` FOREIGN KEY (`disbursmentid`) REFERENCES `cashdisbursment` (`disbursmentID`),
ADD CONSTRAINT `cashdisbursmentrr_ibfk_2` FOREIGN KEY (`reportid`) REFERENCES `receivingreport` (`reportid`);

--
-- Constraints for table `cashreceipts`
--
ALTER TABLE `cashreceipts`
ADD CONSTRAINT `cashreceipts_ibfk_1` FOREIGN KEY (`method`) REFERENCES `chartofaccounts` (`accountid`);

--
-- Constraints for table `cashreceiptsinvoice`
--
ALTER TABLE `cashreceiptsinvoice`
ADD CONSTRAINT `cashreceiptsinvoice_ibfk_1` FOREIGN KEY (`receiptid`) REFERENCES `cashreceipts` (`receiptID`),
ADD CONSTRAINT `cashreceiptsinvoice_ibfk_2` FOREIGN KEY (`invoiceid`) REFERENCES `salesinvoice` (`invoiceid`);

--
-- Constraints for table `invoiceitems`
--
ALTER TABLE `invoiceitems`
ADD CONSTRAINT `invoiceitems_ibfk_1` FOREIGN KEY (`invoiceid`) REFERENCES `salesinvoice` (`invoiceid`),
ADD CONSTRAINT `invoiceitems_ibfk_2` FOREIGN KEY (`itemnumber`) REFERENCES `items` (`itemnumber`);

--
-- Constraints for table `journalentry`
--
ALTER TABLE `journalentry`
ADD CONSTRAINT `journalentry_ibfk_1` FOREIGN KEY (`journalid`) REFERENCES `journal` (`journalid`),
ADD CONSTRAINT `journalentry_ibfk_2` FOREIGN KEY (`accountid`) REFERENCES `chartofaccounts` (`accountid`);

--
-- Constraints for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
ADD CONSTRAINT `purchaseorder_ibfk_1` FOREIGN KEY (`supplierid`) REFERENCES `suppliers` (`supplierid`);

--
-- Constraints for table `purchaseorderitems`
--
ALTER TABLE `purchaseorderitems`
ADD CONSTRAINT `purchaseorderitems_ibfk_1` FOREIGN KEY (`purchaseorderid`) REFERENCES `purchaseorder` (`purchaseorderid`),
ADD CONSTRAINT `purchaseorderitems_ibfk_2` FOREIGN KEY (`itemnumber`) REFERENCES `items` (`itemnumber`);

--
-- Constraints for table `receivingitems`
--
ALTER TABLE `receivingitems`
ADD CONSTRAINT `receivingitems_ibfk_1` FOREIGN KEY (`reportid`) REFERENCES `receivingreport` (`reportid`),
ADD CONSTRAINT `receivingitems_ibfk_2` FOREIGN KEY (`itemnumber`) REFERENCES `items` (`itemnumber`);

--
-- Constraints for table `receivingreport`
--
ALTER TABLE `receivingreport`
ADD CONSTRAINT `receivingreport_ibfk_1` FOREIGN KEY (`purchaseorderid`) REFERENCES `purchaseorder` (`purchaseorderid`);

--
-- Constraints for table `salesinvoice`
--
ALTER TABLE `salesinvoice`
ADD CONSTRAINT `salesinvoice_ibfk_1` FOREIGN KEY (`customerid`) REFERENCES `customers` (`customerid`),
ADD CONSTRAINT `salesinvoice_ibfk_2` FOREIGN KEY (`salesperson`) REFERENCES `users` (`id`);

--
-- Constraints for table `uniqueitem`
--
ALTER TABLE `uniqueitem`
ADD CONSTRAINT `uniqueitem_ibfk_1` FOREIGN KEY (`itemnumber`) REFERENCES `items` (`itemnumber`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
