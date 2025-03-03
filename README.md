# 🐦 Bird Count - C# Solution

This repository contains the solution for the **Bird Count** exercise in C#, part of the **Exercism** learning platform.

The exercise involves analyzing bird sightings over a week and performing various operations on this data.

## 🌜 Description

Each day, the number of birds visiting a particular area is recorded. The `BirdCount` class allows analyzing this data using different methods to answer questions such as:

- How many birds were seen last week?
- How many birds were seen today?
- Were there any days with no sightings?
- How many days were considered "busy" (with 5 or more birds)?

## 🛠️ Implementation

The `BirdCount` class includes the following methods:

### 1⃣ `LastWeek()`
Returns an array containing the number of birds seen over the last week.  
```csharp
public static int[] LastWeek()
```

Example output:
```csharp
[0, 2, 5, 3, 7, 8, 4]
```

### 2⃣ `Today()`
Returns the number of birds seen today (last recorded day).  
```csharp
public int Today()
```

### 3⃣ `IncrementTodaysCount()`
Increments the count of birds seen today by 1.  
```csharp
public void IncrementTodaysCount()
```

### 4⃣ `HasDayWithoutBirds()`
Returns `true` if there was a day with no bird sightings, otherwise `false`.  
```csharp
public bool HasDayWithoutBirds()
```

### 5⃣ `CountForFirstDays(int numberOfDays)`
Returns the total number of birds seen in the first `numberOfDays` days.  
```csharp
public int CountForFirstDays(int numberOfDays)
```

### 6⃣ `BusyDays()`
Counts how many days had 5 or more birds recorded.  
```csharp
public int BusyDays()
```

## 📂 Project Structure
```
📁 BirdCount
│── 📄 BirdCount.cs    // Class implementation
│── 📄 Program.cs      // Test program (optional)
│── 📄 README.md       // This file
```

## 🚀 How to Run

1. Clone this repository:
   ```sh
   git clone https://github.com/gpalomino91/BirdCount-CSharp.git
   cd BirdCount-CSharp
   ```

2. Build the project (make sure you have .NET SDK installed):
   ```sh
   dotnet build
   ```

3. Run the program:
   ```sh
   dotnet run
   ```

## 🏆 Learning Outcomes
This exercise helps to improve skills in:
- Handling arrays in C#.
- Using static and instance methods.
- Searching and counting elements in data structures.
- Conditional logic and loops.

---

💡 Feel free to contribute or improve the solution!  
📢 Got questions? Open an issue or submit a pull request! 🚀
