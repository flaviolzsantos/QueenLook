import React, { Component } from 'react';
import Works from './components/RecentWorks';
import './App.css';

class App extends Component {
  render() {
    return (
        <div className="App">
        <div className="App-menu"></div>
        <div className="App-recentWorks">
          <Works />
        </div>
      </div>
    );
  }
}

export default App;
