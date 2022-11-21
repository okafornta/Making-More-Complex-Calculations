// TASK: Writing a code to add 1 plus 1 times 3
// Multplication has greater priority
Console.WriteLine(1 + 2 * 3);

// Forcing priority using parenthese 
Console.WriteLine((1 + 2)*3);

// Waiting for Enter
Console.ReadLine();


/* DISCUSSION:
 * Note the following about this program:

•   The purpose of this task was to show you that you always have to
    know what exactly needs to be calculated. In this example, you have
    to make up your mind about whether you want to do addition first or
    multiplication first.

•   In basic math rules, multiplication and division have higher priority
    than addition or subtraction. It is the same in programming as in
    mathematics. If you first want to add 1 to 2 and then multiply by 3,
    you need to use parentheses around the 1 and 2.

•   I have not used spaces around the multiplication symbol (asterisk),
    but this has nothing to do with the calculation order. It just looks
    better to me. In C#, spaces and line breaks do not matter. (Of course,
    you should not break a word in the middle.)

•   Finally, the example shows that the computer executes program
    statements in the order they are written. This means from the top
    down.
 */
