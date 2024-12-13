This problem is one of the coding challenge in company
# Reptile Egg Hatch Simulation

## Problem Description  
Design a simulation where a reptile, such as a FireDragon, can lay an egg that hatches into a new reptile. Each egg must hatch exactly once, and attempting to hatch it again should result in an error. The solution must demonstrate this behavior effectively.

## Rules  
1. Each reptile can lay an egg using a method defined in an interface.  
2. Eggs can only be hatched once; multiple hatch attempts should throw an exception.  
3. A factory function ensures eggs create the correct type of reptile when hatched.  

## Explanation  

This solution models reptile reproduction using a combination of interfaces, classes, and object-oriented principles. Here’s a detailed breakdown:  

### 1. **Interface for Reptiles (`IReptile`)**  
The `IReptile` interface ensures that all reptiles, regardless of their specific type (e.g., FireDragon), implement a common method `Lay()` to lay eggs. This creates a clear contract, making it easier to expand the program for other reptiles in the future.

---

### 2. **Egg Lifecycle (`ReptileEgg` Class)**  
The `ReptileEgg` class is the centerpiece of the solution. It represents an egg with the following functionalities:  

- **Factory Function**:  
  The class takes a `Func<IReptile>` (a factory function) as a parameter. This allows the egg to hatch into the correct type of reptile dynamically. For example, a `FireDragon` lays an egg with a factory function that creates a new `FireDragon`.  

- **Hatching Mechanism**:  
  The egg can be hatched once using the `Hatch()` method. A private boolean flag (`_hasHatched`) tracks whether the egg has already hatched.  

- **Error Handling**:  
  If `Hatch()` is called on an already hatched egg, an exception (`InvalidOperationException`) is thrown to prevent unrealistic behavior. This enforces the "one hatch per egg" rule.

---

### 3. **FireDragon Class (`FireDragon`)**  
This class represents a specific type of reptile and implements the `IReptile` interface.  

- **`Lay()` Method**:  
  The `Lay()` method creates a new `ReptileEgg` and passes a factory function (`() => new FireDragon()`) to it. This ensures the egg is tied to its parent type and will always hatch into a `FireDragon`.  

---

### 4. **Simulation**  
In the main program, the behavior is demonstrated:  

- A `FireDragon` instance lays an egg.  
- The egg is hatched, producing a new `FireDragon`.  
- If an attempt is made to hatch the same egg again, the program throws an exception.  

This simulation shows the full lifecycle: laying an egg, hatching it, and ensuring rules like "only one hatch per egg" are enforced.

---

### 5. **Object-Oriented Principles**  
- **Encapsulation**:  
  The `ReptileEgg` class encapsulates the logic for hatching, ensuring no external code can break its rules.  

- **Abstraction**:  
  The `IReptile` interface abstracts the behavior of laying eggs, allowing flexibility for different reptile types.  

- **Reusability**:  
  The design is generic and can be easily extended for other reptiles (e.g., `Snake`, `Lizard`) by implementing the `IReptile` interface.  

---

### 6. **Real-World Modeling**  
The program accurately models a real-world scenario:  
- Reptiles lay eggs that hatch into their offspring.  
- An egg cannot hatch more than once, just like in nature.  
- The factory function ensures the offspring's type matches the parent's type.

This solution combines object-oriented programming and logical constraints to create a robust simulation, making it ideal for demonstrating real-world behaviors in a software system.
