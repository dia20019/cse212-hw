/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Isaac", 3);
        priorityQueue.Enqueue("Cass", 5);
        priorityQueue.Enqueue("Roy", 7);

        for (int i = 0; i < 10; i++)
        {
            var person = priorityQueue.Dequeue();
            if (person == null)
                break;
            Console.WriteLine(person);
        }

        // Defect(s) Found: The Dequeue Method is not really removing the person

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}