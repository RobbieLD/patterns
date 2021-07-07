import Aircraft from "./Aircraft";

class Boeing787_10 extends Aircraft {
    constructor(numberOfSeats:number) {
        super(numberOfSeats);
    }

    public DisplayManufacturerInformation(): string {
        return `Boeing - 787-10`;
    }
}

export default Boeing787_10;