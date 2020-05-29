# Dynamic-Salting-Example
This is a demo project to show the proof of concept behind dynamic salting as opposed to static salting. Many developers mistakenly use the same salt in addition to a user's password to create a new hash. Unfortunately, attackers can pre-compute static salts easily as well by doing the same thing. Using dynamic salting by creating complex functions that determine what the salt is based on user record information can help increase the barrier and reduce the risk of pre-computed attack success rate.
Static salts are commonly broken by cracking software. Exercise dynamic salting through algorithms to increase the complexity for hash reversing.

This is part of a tutorial written on Medium, please follow the link below for more context.
**[Static vs. Dynamic Credential Salting Explained](https://medium.com/swlh/static-vs-dynamic-credential-salting-explained-d2531fded571)**

![VB .NET executable demonstration of dynamic salting differences](https://raw.githubusercontent.com/dc401/Dynamic-Salting-Example/master/dynamic-salt-demo.jpg)
