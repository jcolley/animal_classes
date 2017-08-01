public abstract class Animal {

    public int legs;
    public string name;
    public float weight;
    public string voice{
        get{
            return voice;
        }
        set{
            voice = value;
        }
    }
    public string move;

    public string Speak(){
        return voice;
    }

    public int Move(string move){
        int speed = 0;
        if(move == "run"){
            speed = 20;
        }
        if(move == "swim"){
            speed = 10;
        }
        if(move == "fly"){
            speed = 20;
        }
        return speed;
    }
}

