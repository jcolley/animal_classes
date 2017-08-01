using System;
public abstract class Dog:Animal {
    bool canBeTrained = true;
    string hair; // long or short
    string color;

    public Dog(){
        this.voice = "woof";
    }
}