# PasswordGenerator3090

1) This program prompts the user for a desired lenght (as an int) and whether or not theyd like to include special charecters in their output. Given that information, the program generates a password according to those specifications. The password is simply a string following the desired parameters input by the user.

2) To run the progaram, simply open the repo, including all dependecnies, in Visual Studio and press the run button. Then follow the prompts in the console.

3) The program may produce a bad password. I.e. there is a chance the password includes sensitive infromation, such as names or old passwords. This is because the process for generating is completally random with no checks for such things. Furthermore, the generator may generate a useless password, such as one that consists of only the number one. Finally, the generator produces ugly and hard to use passwords. However, the generator will almsot always produce highly complex passwords that would be nearly impossable (depending on length) to brute force.

4) Because of the simplicity of this program, I find it hard to see how someone may misuse it. In theory, someone could modify my code to remember the output passwords when a user runs the program, saving it to a database of possible passwords to use against them. This is far fetched, though. Nothing in my code as is comprimises its security.

This project is licensed under the terms of the MIT license.
