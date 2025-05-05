import React,{useContext} from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import { SignalRContext } from '../SignalR/SignalRContext';

const Home = () => {
  const signalR = useContext(SignalRContext);
  const { connection, message } = signalR;

  const sendMessage = async () => {
    if (connection) {
      await connection.invoke("SendMessage", "ReactUser", "Hello")
    }
  }
  return (
    <React.Fragment>
      <Header onClickHandler={sendMessage}/>
      <Footer  />
    </React.Fragment>
  );
}

export default Home