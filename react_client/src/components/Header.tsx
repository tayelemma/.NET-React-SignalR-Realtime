import React from 'react'
import { ReactReduxContextValue, useDispatch, UseDispatch, useSelector } from 'react-redux'

interface IHeader {
  onClickHandler: () => void;
}
const Header = (props: IHeader) => {
  const { onClickHandler } = props;
    const dispatch = useDispatch();
    const userLogin = useSelector((state: any) => state.userLogin);
    const { userInfo } = userLogin;

  return (
    <div>Header
      <button onClick={onClickHandler}> Send Message</button>
    </div>
  )
}

export default Header

