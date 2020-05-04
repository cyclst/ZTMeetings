Feature: Bookings
	In order to attend meetings
	As a Zupa Tech Employee
	I want to be able to a book seats

Background: 
	Given a new meeting

@mytag
Scenario: Book Single Seats With Full Seat Availability
	When I book a seat for Employees
	| Employee Name      | Employee Email     |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	Then the booked seats should be
	| Seat Number | Employee Name      | Employee Email     |
	| A1          | Leonard Hofstadter | leonard@zupa.co.uk |

Scenario: Book Maximum Seats With Full Seat Availability
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	| Penny Hofstadter   | penny@zupa.co.uk   |
	| Howard Wolowitz    | howard@zupa.co.uk  |
	Then the booked seats should be
	| Seat Number | Employee Name      | Employee Email     |
	| A1          | Leonard Hofstadter | leonard@zupa.co.uk |
	| A2          | Sheldon Cooper     | sheldon@zupa.co.uk |
	| A3          | Penny Hofstadter   | penny@zupa.co.uk   |
	| A4          | Howard Wolowitz    | howard@zupa.co.uk  |

Scenario: Book Seats With First 8 Seats Already Booked
	Given 8 Seats Have Been Booked By Employees
	When I book a seat for Employees
	| Employee Name      | Employee Email     |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	| Penny Hofstadter   | penny@zupa.co.uk   |
	Then the booked seats should be
	| Seat Number | Employee Name      | Employee Email     |
	| A1          | Test Employee 1    | test1@zupa.co.uk   |
	| A2          | Test Employee 2    | test2@zupa.co.uk   |
	| A3          | Test Employee 3    | test3@zupa.co.uk   |
	| A4          | Test Employee 4    | test4@zupa.co.uk   |
	| A5          | Test Employee 5    | test5@zupa.co.uk   |
	| A6          | Test Employee 6    | test6@zupa.co.uk   |
	| A7          | Test Employee 7    | test7@zupa.co.uk   |
	| A8          | Test Employee 8    | test8@zupa.co.uk   |
	| A9          | Leonard Hofstadter | leonard@zupa.co.uk |
	| A10         | Sheldon Cooper     | sheldon@zupa.co.uk |
	| B1          | Penny Hofstadter   | penny@zupa.co.uk   |

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
	Then the following error should be returned 'Meeting is full. Could not book: Sheldon Cooper'

Scenario: Book More Seats When Meeting Is Full
	Given 100 Seats Have Been Booked By Employees
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	Then the following error should be returned 'Meeting is full. Could not book: Leonard Hofstadter'

Scenario: Book A Seat For An Employee Multiple Times
	Given Seats have been booked for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	When I book a seat for Employees
	| Employee Name      | Employee Email      |
	| Leonard Hofstadter | leonard@zupa.co.uk |
	| Sheldon Cooper     | sheldon@zupa.co.uk |
	Then the following error should be returned 'The following employee already has a seat booked: Leonard Hofstadter'