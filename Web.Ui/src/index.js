import React from 'react';
import { render } from 'react-dom';
import {BrowserRouter as Router, Route, Link} from 'react-router-dom'
import Header from './components/Header'
import Footer from './components/Footer'
import Dashboard from './components/Dashboard';
import './index.css';

render((
  <Router>
    <div>
      <Header/>
      <ul>
        <li><Link to="/">DashBoard</Link></li>
      </ul>
      <hr/>
      <Route exact path="/" component={Dashboard}/>
      <Footer/>
    </div>
  </Router>
), document.getElementById('root'))