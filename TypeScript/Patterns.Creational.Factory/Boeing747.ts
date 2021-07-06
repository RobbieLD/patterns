import IAircraft from "./IAircraft";

class Boeing747_8I implements IAircraft {
    constructor(){}

    TakeOff(): void {
        throw new Error("Method not implemented.");
    }
}

export default Boeing747_8I;