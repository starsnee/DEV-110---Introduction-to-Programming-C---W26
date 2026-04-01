# Week 6: Text Menu App - Study Notes

**Name:**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do while loop is used for when you want the loop dto do something without requirements while a while loop is only for specific requirements

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: It allowed the menu choice to be continuous until there was a different input and automatically DO something without user input/constraints

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used it for the menu so that it would repeat over and over until the exit was hit

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I didnt use a for loop because my only loop needed was a do while and if statement. It was not necessary to have something be done intervally

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: It helps to make the code much more streamlined across different calls to the same function

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: RangeInInt helped me to make sure that the loop would continue until there was a value in those parameteers

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I made sure to check to make sure that they were of the right data types

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: Trim to make shorter strings to upper and lower to change the case, split to give each word its own "string" join to make no spaces and formatting like pad left and right to help make different coordinates for the strings

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: string comparison checks if the strings are the same substring helps to check if parts are similar, ends with checks the last char of the string and indexof helps to check without the last space

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: concatenation is adding the two words together as separate words while interpolation is injecting words (variables) into a string

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.give yourself time to code
2.keep track of variables
3. keep track of the parenthesis and curly brackets
4.
5.

**Which loop felt most natural to use and why?**

Answer: if and do whiles are the easiest for me to interpret with very specific end and start sequences

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [.5 hours]
- String formatting: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Planning and coding the loops was difficult to keep track of and make without messing up variables or syntax

## Reflection

**What would you do differently next time?**

Answer: Give myself more time and make sure that I spend time to mkeep my syntax in line

**How did using three different loop types improve your understanding of repetition?**

Answer: It helped me understand what it takes and how important and useful loops can be to streamline codebases.
