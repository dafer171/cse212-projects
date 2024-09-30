using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with items with data and priority 
    // Expected Result: Repeat tests, 3; Tests, 4; Fix bugs, 5.
    // Defect(s) Found: Nothing
    public void TestPriorityQueue_1()
    {
        var repeating = new PriorityItem("Repeat Tests", 3);
        var testing = new PriorityItem("Tests", 4);
        var fixing = new PriorityItem("Fix bugs", 5);

        var expectedString = "[Repeat Tests (Pri:3), Tests (Pri:4), Fix bugs (Pri:5)]";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(repeating.Value, repeating.Priority);
        priorityQueue.Enqueue(testing.Value, testing.Priority);
        priorityQueue.Enqueue(fixing.Value, fixing.Priority);

        Assert.AreEqual(expectedString, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue function shall remove the item with the highest priority and return its value
    // Expected Result: Fix bugs, 5; Tests, 4; Repeat tests, 3.
    // Defect(s) Found: Function does not remove the item with the highest priority 
    public void TestPriorityQueue_2()
    {
        var repeating = new PriorityItem("Repeat Tests", 3);
        var testing = new PriorityItem("Tests", 4);
        var fixing = new PriorityItem("Fix bugs", 5);

        var expectedString = "Fix bugs";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(repeating.Value, repeating.Priority);
        priorityQueue.Enqueue(testing.Value, testing.Priority);
        priorityQueue.Enqueue(fixing.Value, fixing.Priority);

        var priorityItem = priorityQueue.Dequeue();

        Assert.AreEqual(expectedString, priorityItem);

    }

    // Add more test cases as needed below.
}