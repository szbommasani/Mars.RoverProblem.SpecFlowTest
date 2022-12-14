Feature: MarsRoverProblem

#Scenario:  A test for Rover direction facing and positioning initialisation
#Given A squad of robotic rovers are to be landed by NASA
#When I set the position of the Rover to '1' and '2'
#Then I validate the position facing of the Rover as 'North'
#
#Scenario: A test for moving the rover x and y position and location
#Given A squad of robotic rovers are to be landed by NASA
#When I set the position of the Rover to '1' and '2' and facing 'N'
#Then I validate the position facing of the Rover as 'North'

Scenario: A test to move the rover as per the given scenario problem 3 3 E
Given A squad of robotic rovers are to be landed by NASA
When I set the position of the Rover to '3' and '3' and facing 'E'
And I move the rover 'MMRMMRMRRM'
Then I validate position of the rover as '5 1 E'

Scenario: A test to move the rover as per the given scenario problem 1 2 N
Given A squad of robotic rovers are to be landed by NASA
When I set the position of the Rover to '1' and '2' and facing 'N'
And I move the rover 'LMLMLMLMM'
Then I validate position of the rover as '1 3 N'