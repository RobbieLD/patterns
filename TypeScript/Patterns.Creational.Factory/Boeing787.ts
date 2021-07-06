import IAircraft from "./IAircraft";

class Boeing787_10 implements IAircraft {
    constructor(){}

    TakeOff(): void {
        throw new Error("Method not implemented.");
    }
}

export default Boeing787_10;