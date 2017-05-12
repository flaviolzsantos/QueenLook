import React from 'react'
import NavLink from './components/NavLink'

class App extends React.Component{
  render() {
    return (
      <div>
       <Header/>
        <ul role="nav">
          <li><NavLink to="/" onlyActiveOnIndex>Dashboard</NavLink></li>
        </ul>
        {this.props.children}
       <Footer/>        
      </div>
    )
  }
}

export default App
