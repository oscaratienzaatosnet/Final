1. How long did you spend on the coding test? What would you add to your solution if you had more
time? If you didn't spend much time on the coding test then use this as an opportunity to explain what
you would add.

Along 3 hours. I have started trying to implement all i want and it has last more than i thought, so i 
have to reduce my intentions. 
I wanted to use CsConsoleFormat (or https://github.com/douglasg14b/BetterConsoleTables) but didnt have 
time to try it. It happened the same with command line options (wanted to put some help into it) but didnt 
have time enough. Wanted to add better options to check errors, option to change url by command line. 
I would like to do this with web, but would have taken me more time.

2. What was the most useful feature added to the latest version of your chosen language? Please include
a snippet of code that shows how you've used it.
the commands line of dotnet run/build, i know it is not in last version, but this wasnt when i learnt the 
language. Sintatically the ? to avoid checking nulls

 Assert.Equal(2,machines?.Count);


3. How would you track down a performance issue in production? Have you ever had to do this?

i have tracked down many performance issues in production, most of them were related to memory, and others to
cpu, or other bottlenecks. The memory one with memory dumps each x time, or counting objects each x minutes.

The cpu issues must be tracked separately with process dumps (gdb) or watching in processxp/ps what is the thread 
that is taking the most cpu. And other bottlenecks can be thread problems like dead locks.

4. How would you improve the Lantek API that you just used?
I would add options to order it by name asc/desc, to limit the number of results by size or by name (start with or similar) 
although it can be done in client, depending on how much they are coming it is better not to send too much over network.