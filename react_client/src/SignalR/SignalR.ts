import { HubConnectionBuilder, HubConnection } from "@microsoft/signalr";
import { useEffect, useState } from "react";

 export const useSignalR = () => {
     const [connection, setConnection] = useState<HubConnection | null>(null);
     const [message, setMessage] = useState<string[]>([]);

     useEffect(() => {
         const newConnection = new HubConnectionBuilder()
             .withUrl("https://localhost:5001/message")
             .withAutomaticReconnect()
             .build();
         setConnection(newConnection);
     }, []);
     
     useEffect(() => {
         if (connection) {
             connection
                 .start()
                 .then(() => {
                     console.log("Connected to SingalR");
                     connection.on("ReciveMessage", (user, message) => {
                         setMessage(perv => [...perv, `${user}: ${message}`])
                     });
                 })
                 .catch(error => console.error("Connection faild: ", error));
         }
     },[connection]);
     
    return { connection, message };
}