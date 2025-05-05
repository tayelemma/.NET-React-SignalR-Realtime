import { createContext } from "react";

export interface ISignalR {
    connection: any;
    message: Array<string>;
}
const defaultValue: ISignalR = {
    connection: null,
    message:[]
}
export const SignalRContext = createContext(defaultValue);