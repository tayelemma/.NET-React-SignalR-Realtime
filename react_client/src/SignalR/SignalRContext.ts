import { createContext } from "react";

export interface ISignalR {
    message: string;
    desc: string;
}
const defaultValue: ISignalR = {
    message: "",
    desc:""
}
export const SignalRContext = createContext(defaultValue);