Feature: Bookings
	In order to attend meetings
	As a Zupa Tech Employee
	I want to be able to a book seats

Background: 
	Given there are no booked seats 

@mytag
Scenario: Book Single Seats With Full Seat Availability
	When I book a seat for Employees
	| Employee Name | Employee Email  |
	| Leonard Hofstadter   | leonard@zupa.co.uk |
	Then the booked seats should be
	| Seat Number | Employee Name | Employee Email  |
	| A1          | Leonard Hofstadter | leonard@zupa.co.uk |

Scenario: Book Maximum Seats With Full Seat Availability
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	| Penny Hofstadter   | penny@zupa.co.uk   |
	| Howard Wolowitz    | howard@zupa.co.uk  |
	Then the booked seats should be
	| Seat Number | Employee Name      | Employee Email      |
	| A1          | Leonard Hofstadter | leonard@zupa.co.uk |
	| A2          | Sheldon Cooper     | sheldon@zupa.co.uk |
	| A3          | Penny Hofstadter   | penny@zupa.co.uk   |
	| A4          | Howard Wolowitz    | howard@zupa.co.uk  |

Scenario: Book Seats With First 3 Seats Already Booked
	Given 3 Seats Have Been Booked By Employees
	When I book a seat for Employees
	| Employee Name           | Employee Email         |
	| Raj Koothrappali        | raj@zupa.co.uk        |
	| Bernadette Rostenkowski | bernadette@zupa.co.uk |
	| Amy Farrah Fowler       | amy@zupa.co.uk        |
	Then the booked seats should be
	| Seat Number | Employee Name           | Employee Email         |
	| A1          | Leonard Hofstadter      | leonard@zupa.co.uk    |
	| A2          | Sheldon Cooper          | sheldon@zupa.co.uk    |
	| A3          | Penny Hofstadter        | penny@zupa.co.uk      |
	| A4          | Howard Wolowitz         | howard@zupa.co.uk     |
	| B1          | Raj Koothrappali        | raj@zupa.co.uk        |
	| B2          | Bernadette Rostenkowski | bernadette@zupa.co.uk |
	| B3          | Amy Farrah Fowler       | amy@zupa.co.uk        |

Scenario: Book More Than The Maximum Number Of Seats
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	| Penny Hofstadter   | penny@zupa.co.uk   |
	| Howard Wolowitz    | howard@zupa.co.uk  |
	| Raj Koothrappali   | raj@zupa.co.uk     |
	Then the following error should be returned 'The maximum number of seats that can be booked by an employee is 4'

Scenario: Book More Seats Than Are Available
	Given 99 Seats Have Been Booked By Employees
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	Then the following error should be returned 'Not enough seats available to book. Current seat availability is 1'

Scenario: Book More Seats When Meeting Is Full
	Given 100 Seats Have Been Booked By Employees
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	Then the following error should be returned 'Meeting is full'

Scenario: Book A Seat For An Employee Multiple Times
	Given Seats have been booked for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	Then the following error should be returned 'The following employees already have seats booked: Leonard Hofstadter'