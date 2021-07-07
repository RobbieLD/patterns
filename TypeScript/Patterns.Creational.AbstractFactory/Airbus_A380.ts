import Aircraft from "./Aircraft";

class Airbus_A380 extends Aircraft {
    constructor(numberOfSeats:number) {
        super(numberOfSeats);
    }

    public DisplayManufacturerInformation(): string {
        return `Airbus - A380`;
    }
}

export default Airbus_A380;