import React from "react";
import { Link } from "react-router-dom";
const Home = () => {
  return (
    <div className="dhiwise-navigation">
      <h1>Homepage</h1>
      <p className="headline">
        This project was generated By{" "}
        <a href="https://www.dhiwise.com">Dhiwise</a>. Quickly use below links
        to navigate through all pages.
      </p>
      <ul>
        <li>
          <Link to="/homepagina">HomePagina</Link>
        </li>
        <li>
          <Link to="/loginpagina">LogInPagina</Link>
        </li>
        <li>
          <Link to="/signuppagina">SignUpPagina</Link>
        </li>
        <li>
          <Link to="/menupagina">MenuPagina</Link>
        </li>
        <li>
          <Link to="/profielpagina">ProfielPagina</Link>
        </li>
        <li>
          <Link to="/profielervaringsdeskundigepagina">
            ProfielErvaringsdeskundigePagina
          </Link>
        </li>
        <li>
          <Link to="/onderzoekdoenervaringsdeskundigepagina">
            OnderzoekDoenErvaringsdeskundigePagina
          </Link>
        </li>
        <li>
          <Link to="/onderzoekpagina">OnderzoekPagina</Link>
        </li>
        <li>
          <Link to="/ondersteuningpagina">OndersteuningPagina</Link>
        </li>
        <li>
          <Link to="/chatpagina">ChatPagina</Link>
        </li>
        <li>
          <Link to="/chatervaringsdeskundigebedrijfpagina">
            ChatErvaringsdeskundigeBedrijfPagina
          </Link>
        </li>
        <li>
          <Link to="/bedrijfmenupagina">BedrijfMenuPagina</Link>
        </li>
        <li>
          <Link to="/profielpaginabedrijven">ProfielPaginaBedrijven</Link>
        </li>
        <li>
          <Link to="/onderzoekplaatsenbedrijfpagina">
            OnderzoekPlaatsenBedrijfPagina
          </Link>
        </li>
        <li>
          <Link to="/profielbedrijfpagina">ProfielBedrijfPagina</Link>
        </li>
        <li>
          <Link to="/onderzoekresultatenbedrijfpagina">
            OnderzoekResultatenBedrijfPagina
          </Link>
        </li>
        <li>
          <Link to="/chatsbedrijfervaringsdeskundigepagina">
            ChatsBedrijfErvaringsdeskundigePagina
          </Link>
        </li>
        <li>
          <Link to="/chatbedrijfervaringsdeskundigepagina">
            ChatBedrijfErvaringsdeskundigePagina
          </Link>
        </li>
        <li>
          <Link to="/menubeheerderpagina">MenuBeheerderPagina</Link>
        </li>
        <li>
          <Link to="/profielpaginabeheerder">ProfielPaginaBeheerder</Link>
        </li>
        <li>
          <Link to="/profielbeheerderpagina">ProfielBeheerderPagina</Link>
        </li>
      </ul>
    </div>
  );
};
export default Home;
