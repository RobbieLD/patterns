import IAircraft from "./IAircraft";

class Boeing777X implements IAircraft {
    constructor(){}

    DisplayAircraftData(): string {
        return "Boeing 777 X";
    }
}

export default Boeing777X;