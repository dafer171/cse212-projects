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
    // Expected Result: Fix bugs.
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

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: Fix bugs.
    // Defect(s) Found: Function retunr the last value
    public void TestPriorityQueue_3()
    {
        var repeating = new PriorityItem("Repeat Tests", 3);
        var testing = new PriorityItem("Tests", 4);
        var fixing = new PriorityItem("Fix bugs", 5);
        var documenting = new PriorityItem("Documenting", 5);

        var expectedString = "Fix bugs";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(repeating.Value, repeating.Priority);
        priorityQueue.Enqueue(testing.Value, testing.Priority);
        priorityQueue.Enqueue(fixing.Value, fixing.Priority);
        priorityQueue.Enqueue(documenting.Value, documenting.Priority);

        var priorityItem = priorityQueue.Dequeue();

        Assert.AreEqual(expectedString, priorityItem);

    }
    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: InvalidOperationException("The queue is empty.");
    // Defect(s) Found: Nothing
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}