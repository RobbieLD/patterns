import IAircraft from "./IAircraft";

class Boeing787_10 implements IAircraft {
    constructor(){}

    DisplayAircraftData(): string {
        return "Boeing 787 10";
    }
}

export default Boeing787_10;