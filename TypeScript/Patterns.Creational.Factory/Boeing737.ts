import IAircraft from "./IAircraft";

class Boeing737_Max10 implements IAircraft {
    constructor(){}

    TakeOff(): void {
        throw new Error("Method not implemented.");
    }
}

export default Boeing737_Max10;