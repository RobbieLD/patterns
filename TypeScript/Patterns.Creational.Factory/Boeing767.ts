import IAircraft from "./IAircraft";

class Boeing767_300ER implements IAircraft {
    constructor(){}

    TakeOff(): void {
        throw new Error("Method not implemented.");
    }
}

export default Boeing767_300ER;