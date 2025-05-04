import React from 'react';
export interface IFooter {
    note?: string;
    desc?: string;
}

const Footer: React.FC = ( props: IFooter) => {
 const { note, desc } = props;
  return (
      <div>
          <div>
              {note}
          </div>
          <div className="div">{desc}</div>
    </div>
  )
}

export default Footer;