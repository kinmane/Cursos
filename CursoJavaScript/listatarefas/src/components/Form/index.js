import React from "react";
import ProTypes from "prop-types";
import { FaPlus } from "react-icons/fa";
import "./form.css";

export default function Form({ handleChange, handleSubmit, novaTarefa }) {
  return (
    <form onSubmit={handleSubmit} action="#" className="form">
      <input onChange={handleChange} type="text" value={novaTarefa} />
      <button type="submit">
        <FaPlus />
      </button>
    </form>
  );
}

Form.propTypes = {
  handleChange: ProTypes.func.isRequired,
  handleSubmit: ProTypes.func.isRequired,
  novaTarefa: ProTypes.string.isRequired,
};
