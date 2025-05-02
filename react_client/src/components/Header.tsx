import React from 'react'
import { ReactReduxContextValue, useDispatch, UseDispatch, useSelector } from 'react-redux'

const Header = () => {
    const dispatch = useDispatch();
    const userLogin = useSelector((state: any) => state.userLogin);
    const { userInfo } = userLogin;

  return (
    <div>Header</div>
  )
}

export default Header

