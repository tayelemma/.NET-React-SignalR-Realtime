import {
  combineReducers,
  applyMiddleware,
  legacy_createStore as createStore,
} from "redux";
import { composeWithDevTools } from "redux-devtools-extension";
import { thunk, ThunkMiddleware } from "redux-thunk";
import { userLoginReducer } from "./Reducers/UserReducers";

export interface UserLoginState {
  userInfo: any;
}
export interface RootState {
  userLogin: UserLoginState;
  token: string;
  isActive: boolean;
}

const reducer = combineReducers({
  userLogin: userLoginReducer,
});

const middleware: ThunkMiddleware<RootState>[] = [thunk];
const userInfoFromLocalStorage = localStorage.getItem("userInfo")
  ? JSON.parse(localStorage.getItem("userInfo") as any)
  : null;

const initialState: {} = {
  userLogin: { userInfo: userInfoFromLocalStorage } as any,
  token: "",
  isActive: true,
};

const store = createStore(
  reducer,
  initialState,
  composeWithDevTools(applyMiddleware(...middleware))
);
export default store;
