import IAircraft from "./IAircraft";

class Boeing777X implements IAircraft {
    constructor(){}

    TakeOff(): void {
        throw new Error("Method not implemented.");
    }
}

export default Boeing777X;