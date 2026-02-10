# Week 5: Guess the Number - Study Notes

**Name:**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do while always is used, with while being constrained, while is only able to be used with certain conditions.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: For a continuous loop of during the whoe program with some constraints.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: For the "wrong" inputs to make a sequence of code that runs for a specific reason not the entire time.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop for iterative numbers, this allowed me to run a loop for a certain amount of time dictating when my logic ends.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: It created a way for me to do one very complex method only once and call to it twice.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I made sure that the input would be denied (loop would continue) until there was a valid input.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I used the same method as the one for the min/max of the number value. I just made sure that the loop would not end until the input was less than the max and more than the min.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: It prints to the console that it is invalid and the loop continues

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: the randomNum value, if low print too low. else if high print too high, else correct

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: everytime it was too low or high it added one to the counter

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: i used random within the max and min values and then continued with the generation

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: to make sure it is not too big, rand starts at 0, so it needs 1 more to start at 1

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: letters, huge numbers, and negatives

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]
 my rand was making the same number over and over and then my variables werent gretting called to

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Give yourself time to finish assignments
2. Keep track of variables
3. Playtest multiple different times
4. Use lots of different inputs
5.

**Which loop felt most natural to use and why?**

Answer: the for loop is the one i am most used to and in my head makes the most sense with a set end

## Time Spent

**Total time:** [1.6 hours]

**Breakdown:**

- Planning the loops: [.3 hours]
- Input validation: [.6 hours]
- Guessing logic: [.2 hours]
- Testing and debugging: [.4 hours]
- Writing documentation: [.3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Documentation

## Reflection

**What would you do differently next time?**

Answer: I would try and have my methods and loops better organized

**How did using three different loop types improve your understanding of repetition?**

Answer: It makes me understand how iterative programming works and can be used to make programs more simple.
