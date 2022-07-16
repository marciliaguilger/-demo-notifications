# demo-notifications

This is a demo web api project created to send notifications!
The goal is to train implementation of some design patterns and improve the original code.

The patterns used in this project are:

# Facade

The facade patterns is a structural pattern, used to create simplified abstractions to interact with external libs, frameworks or complex classes.
In this project I implemented the facade to abstract the use of SendGrid framework, creating an Interface with simplified method that receives only the information that matters to send a notification.

