"use strict";
//Functions in TypeScript
Object.defineProperty(exports, "__esModule", { value: true });
function add(a, b) {
    return a + b;
}
var sum = add(1, 2);
var sum = add("Hi", "Hello!!!!!!");
var sum = add(126789.3456, 10.234);
var sum = add("Hi", 3);
console.log(sum);
//Another function
function subtract(a, b) {
    return a - b;
}
var result = subtract(4, 2);
console.log(subtract);
// Anonymous function
let Add = function (x, y) {
    return x + y;
};
//Access modifiers ====>private
class Person {
    constructor(fname, lname, gender) {
        this.fname = fname;
        this.lname = lname;
        this.gender = gender;
        //we intend to create the contr to initialize the value from the same AM
    }
    getBasicInfo() {
        console.log('Name:' + this.fname + '' + this.lname);
        console.log('Gender:' + this.gender);
    }
}
let a = new Person('Priscilla', 'Katherine', 'Female');
a.getBasicInfo();
//Another Example ==>private
class Employee {
    constructor(ID, Name) {
        this.empID = ID;
        this.empName = Name;
    }
    display() {
        // return (`Employee ID :`{ this.empID; + " " + "EmployeeName": { this.Name }`);
        return (`Employee ID :{this.Name}="Priscilla"`);
    }
}
let Emp = new Employee(101, "prisci");
Emp.empID = 101;
console.log(Emp.display());
//Access modifiers ====>public ===> public, so they can be accessible outside of the class using an object of the class
class Student {
}
let std = new Student(); //Instance Created for accessing
std.stdName = "Prsiclla";
std.stdCourse = "MCA";
console.log(std.stdName + " " + std.stdCourse);
//Protected ==> accessible in child classes
class Manager {
    constructor(name, Id) {
        this.empName = name;
        this.empID = Id;
    }
}
class Subordinates extends Manager {
    constructor(name, Id, department) {
        super(name, Id); //By using Super Keyword this class will act as Parent Class 
        this.department = department;
    }
}
let manager = new Subordinates("priscilla", 1, "Developer");
console.log();
//ReadOnly ==>only for reading purpose ==>Read-only members can be accessed outside the class, but their value cannot be changed.
class plant {
    constructor(Name) {
        this.numOfroots = 8; //We cannot assign any values to it they are only for reading purpose
        this.name = Name;
    }
}
let stem = new plant("Hi!!! I'am bhavya");
//Module ===>To avoid conflicts of globally accessing variables we use this concept
//Variable
var x = "Hi!!! This is priscilla"; //Globally Declared
exports.y = "Welcome to Node JS"; //By using this we restrict the use of global variable
//For using we have to import it
//Syntax of Import ==> import{variable name }from <location of the file for importing by using Dot operator and FORWARD SLASH and inside double quotes> 
//import{y} from "./test1/"
//Function
function myfunct() {
    console.log("This is my function");
}
exports.myfunct = myfunct;
//Class
class myclass {
    constructor(a, b) {
        this.a = a;
        this.b = b;
    }
}
exports.myclass = myclass;
//# sourceMappingURL=app.js.map
