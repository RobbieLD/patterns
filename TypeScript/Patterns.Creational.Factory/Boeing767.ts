import IAircraft from "./IAircraft";

class Boeing767_300ER implements IAircraft {
    constructor(){}

    DisplayAircraftData(): string {
        return "Boeing 767 300 ER";
    }
}

export default Boeing767_300ER;