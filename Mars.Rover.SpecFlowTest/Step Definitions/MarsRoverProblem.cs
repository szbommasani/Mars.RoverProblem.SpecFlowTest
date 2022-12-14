using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Mars.Rover.SpecFlowTest.Helper;

namespace Mars.Rover.SpecFlowTest.Step_Definitions
{
    [Binding]
    public sealed class MarsRoverProblem
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        
        private readonly ScenarioContext _scenarioContext;
        public const int N = 1;
        public const int E = 2;
        public const int S = 3;
        public const int W = 4;
        public int x = 0;
        public int y = 0;
        public int facing = N;

        public Mars.Rover.SpecFlowTest.Helper.Rover rover = new Mars.Rover.SpecFlowTest.Helper.Rover();

        //public MarsRoverProblem(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        //[Given("the first number is (.*)")]
        //public void GivenTheFirstNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    _scenarioContext.Pending();
        //}

        //[Given("the second number is (.*)")]
        //public void GivenTheSecondNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    _scenarioContext.Pending();
        //}

        //[When("the two numbers are added")]
        //public void WhenTheTwoNumbersAreAdded()
        //{
        //    //TODO: implement act (action) logic

        //    _scenarioContext.Pending();
        //}

        //[Then("the result should be (.*)")]
        //public void ThenTheResultShouldBe(int result)
        //{
        //    //TODO: implement assert (verification) logic

        //    _scenarioContext.Pending();
        //}

        [Given(@"A squad of robotic rovers are to be landed by NASA")]
        public void GivenASquadOfRoboticRoversAreToBeLandedByNASA()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I set the direction facing of the Rover to '(.*)'")]
        public void WhenISetTheDirectionFacingOfTheRoverTo(string direction)
        {
            //ScenarioContext.Current.Pending();

            
        }

        //[When(@"I set the position of the Rover to '(.*)' and '(.*)' and facing '(.*)'")]
        //public void WhenISetThePositionOfTheRoverToAnd(int x, int y, int facing)
        //{
        //    //ScenarioContext.Current.Pending();
        //    rover.setPosition(x,y,)
        //}


        [Then(@"I validate the position facing of the Rover as '(.*)'")]
        public void ThenIValidateThePositionFacingOfTheRoverAs(string direction)
        {
            //Assert.AreEqual(direction,ScenarioContext)
        }

        [When(@"I move the rover '(.*)'")]
        public void WhenIMoveTheRover(string direction)
        {
            rover.process(direction);
        }

        //[Then(@"I validate position of the rover as '(.*)' and '(.*)'")]
        //public void ThenIValidatePositionOfTheRoverAsAnd(int p0, int p1)
        //{
        //    ScenarioContext.Current.Pending();
        //}


        [When(@"I set the position of the Rover to '(.*)' and '(.*)' and facing '(.*)'")]
        public void WhenISetThePositionOfTheRoverToAndAndFacing(int x, int y, string facing)
        {
            //ScenarioContext.Current.Pending();
            int i = 0;
            if (facing.ToUpper() == "N")
                i = 1;
            else if (facing.ToUpper() == "E")
                i = 2;
            else if (facing.ToUpper() == "S")
                i = 3;
            else if (facing.ToUpper() == "W")
                i = 4;

            rover.setPosition(x, y, i);
        }

        [Then(@"I validate position of the rover as '(.*)'")]
        public void ThenIValidatePositionOfTheRoverAs(string position)
        {
            string outcomePosition = string.Empty;
            outcomePosition = rover.printPosition();
            Console.WriteLine(outcomePosition);
            Assert.AreEqual(position, outcomePosition);
        }
    }
}
