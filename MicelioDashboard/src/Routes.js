import { BrowserRouter, Route, Redirect, Switch } from 'react-router-dom';


import Index from './pages/Index';
import Sign from './pages/Sign';
import Home from './pages/Home';
import About from './pages/About';
import Game from './pages/Game';

import {useAuth} from "./context/AuthContext";

require('dotenv').config();

const Routes = () => {
  const { isAuth, isLoading } = useAuth();

  if(isLoading) {
    return <div />
  }

  if(isAuth){
    return(
      <BrowserRouter basename="/micelio">
        <Switch>
          <Route path={'/home'} component={Home} exact/>
          <Route path={'/sobre'} component={About}/>
          <Route path={'/game/:id'} component={Game}/>
          <Redirect to={'/home'} />
        </Switch>
      </BrowserRouter>
    )
  }

  return(
    <BrowserRouter basename="/micelio">
      <Switch>
        <Route path={'/'} component={Index} exact/>
        <Route path={'/sign'} component={Sign}/>
        <Redirect to={'/'} />
      </Switch>
    </BrowserRouter>
  )



}

export default Routes;
