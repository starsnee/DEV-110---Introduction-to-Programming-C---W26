# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It reads all of the lines and returns each section of the "path" into individual pieces, we used this to grab the string from the file path and separate them into different terms

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: The system would fail, it would get it's own extra number in the array and would throw off the number of terms and an Exception

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: The path is where the data will be stored/written, and the string is what will be written in the file

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select will grab a certain number/position from the array and make sure that it has something to grab data from, and ToArray takes the results and puts them into an array position

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException is when the file has been moved, deleted, or renamed and it helps to figure out what specifically is causing an error in the code

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: It gives a specific error instead of a blanket error that just is given syntax instead of data needed from the program.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. Give your variables memorable names
2. Make a checklist/QA test for each round of testing to check that everything is working properly
3. Clean up your code when done and while coding to prevent errors with syntax

**What was the trickiest part of this assignment and how did you work through it?**

Answer: Keeping track of variables and which functions worked/didnt work when running. I had to make nicknames in my head for each feature and make sure that they were able to run and go down the list of what did and didnt work.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.7 hours
- Implementing LoadHabits: 0.5 hours
- Implementing PrintHabits / PrintSummary: 0.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 0.75 hours
- Testing and debugging: 1 hours
- Writing study notes: 0.25 hours

**Most time-consuming part:**

Answer: The most time consuming part was debugging, I had a lot of issues making sure that everything worked correctly and didnt impose on itself or have a bad variable name, I also needed to make sure that the program ran without a certain component failing as well.
