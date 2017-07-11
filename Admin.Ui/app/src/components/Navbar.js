import React, { Component } from 'react';
import {
  BrowserRouter as Router,
  Route,
  Redirect,
  Link
} from 'react-router-dom';
import Dashboard from './Dashboard';
import Usuarios from './Usuarios';
import Produtos from './Produtos';

class NavBar extends Component {
    render() {
        return (
            <Router>
                <div>
                    <nav className="navbar navbar-default navbar-fixed-top">
                        <div className="container-fluid">
                            <div className="navbar-header">
                                <button type="button" className="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                                    <span className="sr-only">Toggle navigation</span>
                                    <span className="icon-bar"></span>
                                    <span className="icon-bar"></span>
                                    <span className="icon-bar"></span>
                                </button>
                                <Link className="navbar-brand" to="/Admin">Queenlook</Link>
                            </div>
                            <div className="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                <ul className="nav navbar-nav">
                                    <li><Link to="/Admin">Dashboard</Link></li>
                                    <li><Link to="/Admin/Usuarios">Usuários</Link></li>
                                    <li><Link to="/Admin/Produtos">Produtos</Link></li>
                                </ul>                                                              
                        </div>
                        </div>
                    </nav>  
                    <Redirect from="/Admin" to="Admin" />
                    <Route exact path="/Admin" component={Dashboard}/>
                    <Route path="/Admin/Usuarios" component={Usuarios}/>
                    <Route path="/Admin/Produtos" component={Produtos}/>                                  
                </div>
            </Router>
        );
    }
};

export default NavBar;